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
    stage('docker') {
      steps {
        dir ("src/ConqSolid.Web"){
          sh 'sudo docker-compose -f down'
          sh 'sudo docker build -t conqsolid .'
          sh 'sudo docker-compose up'
        }
      }
    }
  }
}