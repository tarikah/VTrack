pipeline  {
    def app
    stages {
        stage('Clone repository') {
            checkout scm
        }
        stage('Build image') {
           app=docker.build("tarikah/VTrack")
        }
         stage('Push image') {
           docker.withRegistry('https://registry.hub.docker.com','dockerhub')
             {
                 app.push("${env.BRANCH_NAME}-${env.BUILD_NUMBER}")
                 app.push("${env.BRANCH_NAME}-latest")
             }
        }
       
    }
}
