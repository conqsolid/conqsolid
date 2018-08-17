pipeline {
  agent any
  stages {
    stage('checkout') {
      steps {
        git(url: 'https://github.com/conqsolid/conqsolid.git', branch: 'master')
      }
    }
  }
}