properties {
  $baseDir = Resolve-Path ".\"
  $baseName = 'MS.TestPlatform'
  $slnFile = "$baseDir\$baseName.Solution.sln"
  $buildConfig = "Debug"
  $compileMessage = 'Executed Compile!'
  $cleanMessage = 'Executed Clean!'
}

task default -depends Compile

task ? -Description "Helper to display task info" {
	Write-Documentation
}

task Compile -depends Clean { 
  exec { msbuild $slnFile /target:Rebuild "/p:Configuration=$buildConfig" }
  $compileMessage
}

task Clean {
  exec { msbuild $slnFile /target:Clean "/p:Configuration=$buildConfig" }
  $cleanMessage
}