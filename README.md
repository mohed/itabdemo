# itabdemo
Demo project to showcase Itab integration

# Run
Open up the project in VS and run the app in a simulator. 

# Test server
There is a test server in the root folder. To run the server we need to have node installed. 
We navigate to the `testserver` folder and use `node echo-server.js` We should now see a message in 
the terminal notifying us that the server is up and running. In order to test the integration
in the app we need to have the server runnig.

Every incomming request to the test server will be logged in the terminal and echoed back to the
sender, to mimic Itab functionality.

# Docs
There is a `docs` in the root folder with the documentation to the itab sesame interface. 
Further more we explain main concepts in inline comments where relevant.