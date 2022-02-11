//загрузки модулей применяется функция
const http = require("http");
//позволяет вам открыть файл
const fs = require("fs");
  
http.createServer(function(request, response){
      
    console.log(`Запрошенный адрес: ${request.url}`);
    const filePath = request.url.substr(1);
    fs.access(filePath, fs.constants.R_OK, err => {
        if(err){
            response.statusCode = 404;
            response.end("Resourse not found!");
        }
        else{
            fs.createReadStream(filePath).pipe(response); // pipe поток для чтения
        }
      });
}).listen(3000, function(){
    console.log("Server started at 3000");
});