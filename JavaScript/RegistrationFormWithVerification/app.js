const mainForm = document.forms[0];

var validationSummary = "";

function Validate(form){

    let result = true;
    let validRadio = false;
    var radios = document.getElementsByName("but1");
    var checkBoxes = document.getElementsByName("check1");
    var i = 0;
    var j = 0;
    var checkCounter = 0;

    validationSummary = "";

    const userName = document.querySelector("input[name='userName']").value;
    const userSurname = document.querySelector("input[name='userSurname']").value;
    const userMail = document.querySelector("input[name='userMail']").value;
    
    const userAge = document.querySelector("input[name='userAge']").value;

    var str = userAge.split("-");

    var dd = str[2];
    var mm = str[1];
    var yy = str[0];
    
    // узнаем текущую дату

    var d = new Date();
    var ds = d.getDate();
    var ms = d.getMonth()+1;
    var ys = d.getFullYear();

    var days = ((18*12)*30)+(ms*30)+ds;

    var age = (((ys-yy)*12)*30)+((12-mm)*30)+parseInt(30-dd);

    
    if(!userName)
    {
        result = false;
        validationSummary += "Поле имени не может быть пустым<br />";
    }

    if(!userSurname)
    {
        result = false;
        validationSummary += "Поле фамилии не может быть пустым<br />";
    }

    if(!userMail)
    {
        result = false;
        validationSummary += "Поле почты не может быть пустым<br />";
    }

    // валидация возраста
    
    if((days-age) >= '0'){
        result = false;
        validationSummary += "Ваш возраст меньше 18!<br />";
    }


    //валидация радиобатонов
    while(!validRadio && i<radios.length){
        if(radios[i].checked) validRadio = true;
        i++;
    }
    if(!validRadio){
        result = false;
        validationSummary += "Нужно выбрать пол!<br />";
    } 

    //валидация чекбоксов

    while(j<checkBoxes.length){
        if(checkBoxes[j].checked) checkCounter++;
        j++;
    }
    
    if(checkCounter < 3)
    {
        result = false;
        validationSummary += "Нужно выбрать как минимум 3 технологии!<br />";
    }
    
    return result;
}

mainForm.addEventListener("submit", function(e){

    e.preventDefault();

    if(Validate())
    {
        this.submit();
        alert("Спасибо, мы с Вами свяжемся!");
    }
    else{
        document.querySelector("div[name='errorLog']").innerHTML = validationSummary;
    }


});