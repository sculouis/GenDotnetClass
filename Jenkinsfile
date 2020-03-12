pipeline {
    agent none 
    stages {
        stage('Build') { 
            agent {
                docker {
                    image 'python:3-alpine' 
                }
            }
            steps {
                withEnv(["HOME=${env.WORKSPACE}"]){
                sh 'pip install -r requirements.txt --user'
                sh 'python -m py_compile Library/ReadXls.py' 
            }
            }
            post {
                cleanup {
                    cleanWs()
                }
            }
        }
	  stage('Test') {
            agent {
                docker {
                    image 'qnib/pytest'
                }
            }
            steps {
                    withEnv(["HOME=${env.WORKSPACE}"]){
                sh 'pip install -r requirements.txt --user'
                sh 'py.test --verbose --junit-xml test-reports/results.xml tests/test_readxls.py'
            }
            }
            post {
                always {
                    junit 'test-reports/results.xml'
                }
            }
        }
}
}