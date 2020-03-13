pipeline {
    agent {
        docker {
            image 'python:3.7.3-alpine'
        }
    }
    stages {
        stage('Prepare') {
            steps {
                withEnv(["HOME=${env.WORKSPACE}"]) {
                    sh 'python --version'
                    sh 'pip install --upgrade pip --user'
                    sh 'pip install -r requirements.txt --user'
                    sh 'pip list'
                }
            }
        }
        stage('Build') {
            steps {
                sh 'python -m py_compile Library/ReadXls.py'
            }
        }
        stage('Test') {
            steps {
                withEnv(["HOME=${env.WORKSPACE}"]) {
                    sh 'pip list'
                    sh 'echo $PATH'
                    sh 'python -m pytest'
                }
            }
        }
    }
}