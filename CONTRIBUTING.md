# Contributing

## Before opening a pull request

- Search existing issues and pull requests.
- Discuss material API or generated-client changes in an issue first.
- Keep generated changes reproducible through the scripts in `eng/`.
- Run `dotnet test Greenflux.Sdk.sln -c Release`.

Do not commit API keys, service tokens, production data, or credentials.

## Commit messages and releases

This repository uses [Conventional Commits](https://www.conventionalcommits.org/).

- `fix:` creates a patch release.
- `feat:` creates a minor release.
- `feat!:` or `BREAKING CHANGE:` creates a major release.
- `docs:`, `test:`, `refactor:`, and `chore:` do not create a release on their own.

After qualifying changes merge to `main`, Release Please opens or updates a generated release pull request. Merge that release pull request; it updates the version and changelog, creates the Git tag and GitHub Release, then publishes the tag to NuGet. Do not manually edit `CHANGELOG.md`, create release tags, or increment the package version for normal releases.
