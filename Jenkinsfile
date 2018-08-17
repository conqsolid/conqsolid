pipeline {
  agent any
  stages {
    stage('checkout') {
      steps {
        git(url: 'https://github.com/conqsolid/conqsolid.git', branch: 'master')
      }
    }
    stage('test') {
      steps {
        sh 'dotnet test tests/ConqSolid.FunctionalTests/ConqSolid.FunctionalTests.csproj'
      }
    }
    stage('change directory') {
      steps {
        sh 'cd src/ConqSolid.Web'
      }
    }
    stage('compose down') {
      steps {
        sh 'sudo docker-compose down -f src/docker-compose.yml'
      }
    }
  }
}