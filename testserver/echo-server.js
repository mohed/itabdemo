var net = require('net');
console.log('Server started');
net.createServer(function(socket){
    socket.on('data', function(data){
	console.log(data.toString())
        socket.write(data.toString())
    });
}).listen(25803);
