#!/bin/bash

exit 0

startPath=`pwd`

mono ../libs/NUnit-2.6.3/bin/nunit-console.exe ../build/Oats.Tests/bin/Debug/Oats.Tests.dll && exit 1

cd $startPath
