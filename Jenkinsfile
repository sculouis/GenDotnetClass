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
                sh 'sudo pip install openpyxl'
                sh 'python -m py_compile Library/ReadXls.py' 
            }
        }
	  stage('Test') {
            agent {
                docker {
                    image 'qnib/pytest'
                }
            }
            steps {
                sh 'py.test --verbose --junit-xml test-reports/results.xml tests/test_readxls.py'
            }
            post {
                always {
                    junit 'test-reports/results.xml'
                }
            }
        }
}
}