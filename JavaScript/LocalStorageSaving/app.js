const btnLogin = document.getElementById('log_btn');
const isCheck = document.getElementById('flexCheckDefault');
const checkData = document.getElementById('check_data');



btnLogin.addEventListener("click", ()=>{

    const userName = document.getElementById('userName').value;
    const password = document.getElementById('pass').value;

    if(isCheck.checked == true){
        if(window.localStorage != undefined){
            const ls = window.localStorage;
            ls.setItem("userName", `${userName}`);
            ls.setItem("password", `${password}`);
        }
        else{
            document.cookie += `Name=${userName}; Value=${password}`; 
        }
    }
    else{
        const ls = window.localStorage;
        ls.clear();
    }

});


checkData.addEventListener("click", ()=>{

    var ls = window.localStorage;
    const userNameInput = document.getElementById('userName');
    const passwordInput = document.getElementById('pass');

    if(ls.length != 0){
        userNameInput.value = ls.getItem("userName");
        passwordInput.value = ls.getItem("password");
    }
    else{
        alert("You don't have data in the Storage!");
    }
});


