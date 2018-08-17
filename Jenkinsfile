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
<<<<<<< HEAD
=======
    stage('change directory') {
      steps {
        dir(path: 'src/ConqSolid.Web')
      }
    }
>>>>>>> e1ac8b13682d26785bfdb1a3bccbe0cd4d22777b
    stage('docker') {
      steps {
        dir 'src/ConqSolid.Web'{
          sh 'sudo docker-compose -f down'
          sh 'sudo docker build -t conqsolid .'
          sh 'sudo docker-compose up'
        }
      }
    }
  }
}