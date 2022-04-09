# DeployToNuget
Deploying a class library to nuget 

https://acraven.medium.com/a-nuget-package-workflow-using-github-actions-7da8c6557863

https://github.com/acraven/blog-nuget-workflow-github-actions


dotnet build --configuration Release /p:Version=0.0.1
dotnet test --configuration Release /p:Version=0.0.1 --no-build
dotnet pack --configuration Release /p:Version=0.0.1 --no-build --output .
dotnet nuget push Vivek.SimpleNuGet.Workflow.0.0.1.nupkg --source https://api.nuget.org/v3/index.json --api-key YourApiKeyWillComeHere

Run the following commands to build and publish the package to nuget.org
git tag v0.0.2
git push origin v0.0.2

https://docs.github.com/en/actions/monitoring-and-troubleshooting-workflows/adding-a-workflow-status-badge


dotnet build --configuration Release src/SimpleClassLib/SimpleClassLib.csproj
dotnet pack  --no-build -c Release src/SimpleClassLib/SimpleClassLib.csproj -o .





  <ItemGroup>
    <None Include="images\nuget-logo-og-600x600.png" Pack="true" PackagePath="">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="images\ccc.jpeg" Pack="true" PackagePath="">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>

      
