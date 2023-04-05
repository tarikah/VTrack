node {
    def app

    stages {
        stage('Clone repository') {
            checkout scm
        }
        stage('Build image') {
           app=docker.build("tarikah/VTrack")
        }
       
    }
}
