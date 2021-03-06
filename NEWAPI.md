Adding a package for a new API
==============================

While this process will usually be performed by Googlers, there's
nothing confidential about it, and it may be of interest to third
parties.

Prerequisites:

- `git`
- `bash` (on Windows, the version that comes with Git for Windows)
- `wget`
- Python 3 on the path as `python`
- .NET Core SDK, suitable for the version specified in `global.json`

*Almost* all of the generation process works fine on Linux and
should work on OSX too (untested). Bigtable has a post-generation
step that currently requires Windows, but that's skipped on
non-Windows platforms so should only affect Bigtable developers.

Relevant repositories:

- [googleapis](https://github.com/googleapis/googleapis): API definitions
- [gapic-generator-csharp](https://github.com/googleapis/gapic-generator-csharp): C# microgenerator
- [google-cloud-dotnet](https://github.com/googleapis/google-cloud-dotnet): This repository, where code will end up

This list of instructions looks daunting, but it's not as bad as it
seems: it aims to be pretty comprehensive, although it assumes you
know how to use `git` appropriately.

Step 1: Fork google-cloud-dotnet on github
------------------------------------------

Our process is to merge from user-owned forks, so first fork this
repo and clone it locally, using an https URL (rather than SSH).

We tend to use named branches on the forks, although that's not
*strictly* necessary. So for example:

```sh
git checkout -b add-new-api-package
```

Step 2: Clone googleapis within your google-cloud-dotnet
--------------------------------------------------------

Currently, the tooling for adding an API expects to find a clone of
the googleapis repo directly under the root of the
google-cloud-dotnet repo, but doesn't perform the clone for you.

The simplest way of achieving this is just to generate an existing
API, e.g.

```sh
./generateapis.sh Google.Cloud.Speech.V1
```

The generation tooling *does* clone the repo for you. This will also
validate that your environment is working. That command should end
with:

```text
Generating Google.Cloud.Speech.V1
```

Reset your google-cloud-dotnet clone afterwards (which won't touch googleapis)

```sh
git reset --hard
```

Step 3: Check the API is correct in googleapis
----------------------------------------------

For the rest of the process, you'll need to know the package name
you're trying to generate, which is in Pascal-case. Examples include:

- Google.Cloud.Speech.V1
- Google.Cloud.AssuredWorkloads.V1Beta1
- Google.Cloud.BigQuery.V2

Note how the "B" of "V1Beta1" is capitalized, as are the "W" of
"Workloads" and "Q" of "Query". If you have any doubts about the
desired package name, raise an issue rather than creating a package
with the wrong casing.

Likewise, Cloud APIs should be generated with "Google.Cloud" as the
start of the package name, even if they're not under a
`google.cloud` package in googleapis. Again, raise an issue if you
have any concerns.

The API should be present in the googleapis repo, including:

- Protos describing the service (e.g. [datastore v1](https://github.com/googleapis/googleapis/tree/master/google/datastore/v1)
- A JSON file with gRPC configuration (e.g. [datastore v1](https://github.com/googleapis/googleapis/blob/master/google/datastore/v1/datastore_grpc_service_config.json))

Check that these files all exist, and check that the C# namespace is
appropriate. The protos should contain `csharp_namespace` options
unless the default capitalization produces the correct result.

If anything doesn't match your expectations, please file an issue in
this repo and we'll get it sorted. (There are complexities here around internal processes.)

Step 4: Modify the API catalog
------------------------------

The "release manager" tooling can add a new package, if its API is present and
correct in googleapis. This is run via the `prepare-release.sh`
script. Use the "add" subcommand, with the package name. For
example, if you wanted to add the Google.Cloud.Dialogflow.Cx.V3
package, you'd run:

```sh
./prepare-release.sh Google.Cloud.Dialogflow.Cx.V3
```

This will modify the API catalog (`apis/apis.json`) and show you the
entry it's added. Note that currently there are two aspects which
are not automatically populated:

- Tags
- The product URL (for documentation)

These should be edited into apis.json by hand at some point before
the first release. Note that the tooling sets the version to
"1.0.0-beta00" by default, which is effectively "the version before
the first beta release".

Once you're happy with the change, commit it with an explanatory
message, e.g.

```sh
git commit -a -m "Add Google.Cloud.Dialogflow.Cx.V3 to the API catalog"
```

Step 5: Generate and build the source code and projects
-------------------------------------------------------

There are two generation steps here: generating the C# files, and
then generating the project files to go along with them.

First, run `generateapis.sh`, specifying the ID of the package:

```sh
./generateapis.sh Google.Cloud.Dialogflow.Cx.V3
```

If all goes well, this should just write (after a few seconds):

```text
Generating Google.Cloud.Dialogflow.Cx.V3
```

That step generates just the C# source code. Next, generate the
project files:

```sh
./generateprojects.sh
```

(Note that you don't need to specify the package name here - it
regenerates *all* the projects - as well as a few other files, if
necessary.)

Use `git status` to check that a new directory has been created
(`apis/Google.Cloud.Dialogflow.Cx.V3` in this example).

Now we can build the package and run the unit tests:

```sh
./build.sh Google.Cloud.Dialogflow.Cx.V3
```

If anything fails here, it's likely to be either an API
configuration problem, or a generator problem. Either way, raise a
GitHub issue - unless you're feeling particularly patient, it's
probably worth waiting for someone on the team to look at it.

If all has gone well, however (which it will do 90+% of the time),
you can now commit everything:

```sh
git add --all
git commit -m "Generate Google.Cloud.Dialogflow.Cx.V3"

Step 6: Add smoke tests (where suitable)
----------------------------------------

It's useful to be able to check that the service is actually alive
and listening for requests. Release manager is able to detect good
candidates for non-destructive smoke tests. Run it with the
`suggest-smoke-tests` command, specifying the package ID:

```sh
./prepare-release.sh suggest-smoke-tests Google.Cloud.Dialogflow.Cx.V3
```

For some APIs, there are no suitable (detected) methods. If that's
the case, you'll see output ending in:

```text
Number of smoke tests suggested: 0
```

That's okay - it's not ideal, but it's not a blocker.

If smoke tests *are* suggested, the output will end with a block of
JSON and then a line saying that the JSON has been written to
a `smoketests.json` file (within the `apis/your-package-id`
directory).

**Please review smoke tests before running or committing them.**
In particular, if the RPC sounds like it might be "dangerous" based
on the name (such as the Vision API's `PurgeProducts` method),
you'll want to look really, really carefully.

Once you've reviewed the smoke tests, enable the API in the
[Cloud Console API
dashboard](https://console.cloud.google.com/apis/dashboard) and then
run them with release manager. To run the smoke tests, use the
`smoke-test` command, specifying the package ID and the name of your
project:

```sh
./prepare-release smoke-test Google.Cloud.Dialogflow.Cx.V3 my-project-id
```

Note that this assumes you have application default credentials
configured for the specified project.

Assuming the smoke tests pass, add and commit them:

```sh
git add --all
git commit -m "Add smoke tests for Google.Cloud.Dialogflow.Cx.V3"
```

Step 7: Create a pull request
-----------------------------

Push your branch to your GitHub fork, and create a pull request in
the normal way. Note that this will *not* publish a package when
merged.

Step 8 (Optional): Release the first package for the API
---------------------------------------------------------

Follow the [releasing process](PROCESSES.md) to push a package to
nuget.org. If you do this, also update the root documentation
(`README.md` and `docs/root/index.md`) to indicate this.

(You *can* combine steps 1-6 above with the release process, so that
a single PR adds the API package and releases 1.0.0-beta01, but
that's not recommended unless you're confident in both the process
and the API in question.)
