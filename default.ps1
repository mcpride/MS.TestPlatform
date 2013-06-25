properties {
  $baseDir = Resolve-Path ".\"
  $baseName = 'MS.TestPlatform'
  $slnFile = "$baseDir\$baseName.Solution.sln"
  $buildConfig = "Debug"
  $compileMessage = 'Executed Compile!'
  $cleanMessage = 'Executed Clean!'
  $frameworkpath = "$env:systemroot\Microsoft.NET\Framework\v4.0.30319\"
  $msbuild = $frameworkpath + "msbuild.exe"
}

task default -depends Compile

task ? -Description "Helper to display task info" {
	Write-Documentation
}

task Compile -depends Clean { 
  exec { Invoke-Expression "$msbuild $slnFile /target:Rebuild /p:Configuration=$buildConfig" }
  $compileMessage
}

task Clean {
  exec { Invoke-Expression "$msbuild $slnFile /target:Clean /p:Configuration=$buildConfig" }
  $cleanMessage
}