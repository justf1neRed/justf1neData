const readline = require("readline");
const fs = require('fs');

const ioInterface = readline.createInterface({

    input: process.stdin,
    output: process.stdout
});

const menu = `1 - create file 
2 - delete file
3 - create directory
4 - delete directory
5 - rename file
6 - rename directory
7 - copy file\n`;

ioInterface.question(menu, function(option){

    switch(option)
    {
        case '1':
        case '2':
            ioInterface.question("Enter file name\n", function(fileName){

                switch(option)
                {
                    case '1':
                        fs.writeFile(fileName, "sampleText", function(err){});
                        break;

                    case '2':
                        fs.unlink(fileName, function(err){});
                        break;
                }
                
                ioInterface.close();
            });
            break;

        case '3':
        case '4':
            ioInterface.question("Enter dir name:\n", function(dirName){

                switch(option)
                {
                    case '3':
                        fs.mkdir(dirName, function(err){});
                        break;

                    case '4':
                        fs.rmdir(dirName, {recursive: true}, function(err){});
                        break;
                }

                ioInterface.close();
            });
            break;

        case '5':
            ioInterface.question("Enter file name:\n", function(fileName){

                ioInterface.question("Enter new file name:\n", function(newName){

                    fs.rename(fileName, newName, function(err){});
                    ioInterface.close();
                })
            });
            break;

        case '6':
            ioInterface.question("Enter dir name:\n", function(dirName){

                ioInterface.question("Enter new dir name:\n", function(newName){

                    fs.rename(dirName, newName, function(err){});
                    ioInterface.close();
                })
            });
            break;

        case '7':
            ioInterface.question("Enter file name:\n", function(fileName){

                ioInterface.question("Enter new path:\n", function(newPath){

                    fs.copyFile(fileName, newPath, function(err){});
                    ioInterface.close();
                })
            });
            break;        
    }
    
});