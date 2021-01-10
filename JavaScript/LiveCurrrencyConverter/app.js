const currencyArray = ["https://free.currconv.com/api/v7/convert?q=USD_UAH&compact=ultra&apiKey=c10e2acf4b02dd279d76",
"https://free.currconv.com/api/v7/convert?q=USD_EUR&compact=ultra&apiKey=c10e2acf4b02dd279d76",
"https://free.currconv.com/api/v7/convert?q=USD_CNY&compact=ultra&apiKey=c10e2acf4b02dd279d76"];

const goButton = document.querySelector("button[name='beginExchange']");
const exchangeResult = document.querySelector("div[name='exchRes']");
const currOptions = document.getElementById("currency");
var USDtoUAH, USDtoEUR, USDtoCNY;

//функция, которая получает значения с API и возвращает промис
function getCurrency(url){

    const errorMsg = "Error loading currency information!";

    return new Promise((resolve, reject) =>{

        const getCurrencyRequest = new XMLHttpRequest();

        getCurrencyRequest.open("GET", url);

        getCurrencyRequest.onload = ()=>{

            if(getCurrencyRequest.status == 200){
                
                const currObject = JSON.parse(getCurrencyRequest.responseText);

                resolve(currObject);
            }
            else{

                reject(new Error(errorMsg));
            }
        };

        getCurrencyRequest.onerror = ()=>{
            reject(new Error(errorMsg));
        };

        getCurrencyRequest.send();
    });
}

goButton.addEventListener("click", ()=>{

    const mainInput = document.querySelector("input[name='mainInput']").value;
    var selectedOption = currOptions.options[currOptions.selectedIndex].text;
    
    if(!isNaN(mainInput))
    {
        switch(selectedOption)
        {
            case "UAH":{
            getCurrency(currencyArray[0])
                        .then((curr)=>{
                            exchangeResult.innerHTML = mainInput + " UAH = " + (mainInput/curr.USD_UAH).toFixed(2) + " USD";
            })
            .catch((error)=>{
                console.dir(error.message);
            });
                break;
            }
            case "EUR":{
                getCurrency(currencyArray[1])
                        .then((curr)=>{
                            exchangeResult.innerHTML = mainInput + " EUR = " + (mainInput/curr.USD_EUR).toFixed(2) + " USD";
            })
            .catch((error)=>{
                console.dir(error.message);
            });
                break;
            }
            case "CNY":{
                getCurrency(currencyArray[2])
                        .then((curr)=>{
                            exchangeResult.innerHTML = mainInput + " CNY = " + (mainInput/curr.USD_CNY).toFixed(2) + " USD";
            })
            .catch((error)=>{
                console.dir(error.message);
            });
                break;
            }
        }
    }
    else{
        alert("Incorrect data!");
    }
     
});


            