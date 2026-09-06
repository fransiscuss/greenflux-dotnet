# Changelog

## [1.0.0](https://github.com/fransiscuss/greenflux-dotnet/compare/v0.2.2...v1.0.0) (2026-09-06)


### ⚠ BREAKING CHANGES

* the package no longer depends on Newtonsoft.Json and no longer uses its attributes. Model properties that had underscores are now PascalCase, the protected GreenfluxApiClient.JsonSerializerSettings is now JsonSerializerOptions, and an untyped response payload surfaces as a JsonElement rather than a JObject/JArray.
* net9.0 is no longer a target framework.

### Features

* migrate to System.Text.Json and clear out the NSwag residue ([bf08962](https://github.com/fransiscuss/greenflux-dotnet/commit/bf08962f8cb12501471a61ddc92d10fc2ef45358))
* modernize packaging, CI and release flow ([0320e67](https://github.com/fransiscuss/greenflux-dotnet/commit/0320e67a6bd4fb438da717a3f3157edd4a2e1065))


### Bug Fixes

* correct the documented harness command and run it on both runtimes ([c87381b](https://github.com/fransiscuss/greenflux-dotnet/commit/c87381b08703f2ab7258ffd0097506f85cbb5f9e))
* correct the rationale for the analyzer suppressions ([bcc593e](https://github.com/fransiscuss/greenflux-dotnet/commit/bcc593e9b0816b5bf0d30a33c6ed2575b60e2a1c))

## [0.2.2](https://github.com/fransiscuss/greenflux-dotnet/compare/v0.2.1...v0.2.2) (2026-09-05)


### Bug Fixes

* update package docs and action runtimes ([848d385](https://github.com/fransiscuss/greenflux-dotnet/commit/848d38509a5b59f6887c722b41a908629e5b3992))
* update package docs and action runtimes ([7ec6e56](https://github.com/fransiscuss/greenflux-dotnet/commit/7ec6e569dc1cd4836cf32a33de27d7f79320e9a9))

## [0.2.1](https://github.com/fransiscuss/greenflux-dotnet/compare/v0.2.0...v0.2.1) (2026-09-05)


### Bug Fixes

* TrySendGetAsync catches 400 in addition to 404 ([878cf90](https://github.com/fransiscuss/greenflux-dotnet/commit/878cf901eb0bfdf9b690d37c46bdadf392d6d3f1))
* TrySendGetAsync catches 400 in addition to 404 ([7ef205d](https://github.com/fransiscuss/greenflux-dotnet/commit/7ef205d36857047c1b516c559421230e3d12fa8d))

## [0.2.0](https://github.com/fransiscuss/greenflux-dotnet/compare/v0.1.5...v0.2.0) (2026-09-04)


### Features

* add TryGet-style methods for 404-safe reads ([d5b1582](https://github.com/fransiscuss/greenflux-dotnet/commit/d5b1582790c0a0b90bc123e49ae270c655412a2c))
* add TryGet-style methods for 404-safe reads ([15c3b30](https://github.com/fransiscuss/greenflux-dotnet/commit/15c3b30438268675a3862cf48c2ba85e401938c0))
