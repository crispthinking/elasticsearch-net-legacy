#! /usr/bin/env bash

dotnet build --configuration Release &&
	dotnet test --configuration Release --no-build &&
	dotnet pack --output=./artifacts --no-build --configuration Release