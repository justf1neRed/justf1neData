const express = require('express')
const hbs = require('hbs')
const path = require('path')

const app = express()

const weatherData = require('../utils/weatherData')

const port = process.env.PORT || 3000

const publicStaticDirPath = path.join(__dirname,'../public')

const viewsPath = path.join(__dirname,'../templates/views')
const partialsPath = path.join(__dirname,'../templates/partials')

app.set('view engine', 'hbs')
app.set('views', viewsPath)
hbs.registerPartials(partialsPath)

//указываем где находятся статические файлы
app.use(express.static(publicStaticDirPath))


app.get('', (req, res) =>{
    res.render('index', {
        title: 'Test Weather App'
    })
})

//localhost:3000/weather?address
app.get('/weather', (req, res) =>{
    const address = req.query.address
    if(!address){
        return  res.send({
            error: "The search box can't be empty"
        })
    }


    weatherData(address, (error, {temperature, description, cityName})=>{
        if(error){
            return res.send({
                error
            })
        }
        console.log(temperature, description, cityName)
        res.send({
            temperature,
            description,
            cityName
        })
    })
})

app.get("*",(req, res) =>{
    res.render('404',{
        title: 'Page not found'
    })
})



app.listen(port, () =>{
    console.log("Server is running on port: ", port)
})