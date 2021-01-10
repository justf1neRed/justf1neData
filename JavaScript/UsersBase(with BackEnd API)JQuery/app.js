//api source
const apiUrl = 'http://localhost:55772/api/';

//load btn
const loadBaseBtn = $('#loadBaseBtn');

loadBaseBtn.click(() =>{
    showAllUsers();
});

// cancel btn
const cancelBtn = $('#cancelBtn');

cancelBtn.click(()=>{
    showAllUsers();
});

//show users
function showAllUsers()
{
    $.get(apiUrl + 'users', (data) => {
        $('#tableDiv').css('visibility', 'visible');
        $('#addEditDiv').css('visibility', 'collapse');
        bringUsersFromBackend(data);
    });
}

//variables for validation
var validTextFields = 3;
var validPassword = 8;

//create new user logic
$('#createUserBtn').click(()=>{
    $('#addEditDiv').css('visibility', 'visible');

    $('#okayUserBtn').click(() => {
        if(ValidInfo()){
            let newUser = 
            {
                FirstName: $('#FirstName').val(),
                LastName: $('#LastName').val(),
                MiddleName: $('#MiddleName').val(),
                Password: $('#Password').val(),
                BirthDate: $('#BirthDate').val(),
                Registered: new Date().toJSON()
            };
            $.post(apiUrl + 'Users', newUser,()=>{ showAllUsers();});
        }
        else{
            alert('Information Error!');
        } 
    });
});

// func to work with backend
function bringUsersFromBackend(data)
{
    /*Этот шаг мне очень не нравится, но я так и не смог сделать ничего вместо
    Из-за этого решения при загрузке из базы теряются заголовки таблицы
    Пытался очищать таблицу через tBody.deleteRow(index) а именно:
    while (tablename.tBodies[0].rows[0]) {
    tablename.tBodies[0].deleteRow(0);
    но добиться желаемого так и не удалось, так что костыль остался*/
    $('#mainTable').children().remove();

    for(let i = 0; i < data.length; i++)
    {
        let $row = $('<tr>'+ 
        `<td>${data[i].UserID}</td>`+
        `<td>${data[i].FirstName}</td>`+
        `<td>${data[i].LastName}</td>`+
        `<td>${data[i].MiddleName}</td>`+
        `<td>${data[i].Password}</td>`+
        `<td>${data[i].Picure}</td>`+
        `<td>${data[i].BirthDate}</td>`+
        `<td>${data[i].Registered}</td>`+
        '</tr>'
        );    

        $('#mainTable').append($row);

        // updating information part
        $row.append('<input type = "button" name = "btnEditItem" value = "Edit">').on('click', 'input[value = "Edit"]',(e) =>{
            
            $('#addEditDiv').css('visibility', 'visible');
            
            let cuccrentDataRow = $row.children();

            $('#FirstName').val(cuccrentDataRow[1].innerHTML);
            $('#LastName').val(cuccrentDataRow[2].innerHTML);
            $('#MiddleName').val(cuccrentDataRow[3].innerHTML);
            $('#Password').val(cuccrentDataRow[4].innerHTML);

            $('#okayUserBtn').click(() => {
                let editUser = 
                {
                    UserID:cuccrentDataRow[0].innerHTML,
                    FirstName: $('#FirstName').val(),
                    LastName: $('#LastName').val(),
                    MiddleName: $('#MiddleName').val(),
                    Password: $('#Password').val(),
                    BirthDate: $('#BirthDate').val(),
                    Picture: cuccrentDataRow[5].innerHTML,
                    Registered: cuccrentDataRow[6].innerHTML
                };
             
                if(validator())
                {
                    $.ajax({
                        url: apiUrl + 'Users',
                        data: editUser,
                        type: 'PUT', 
                        traditional: true,                
                        success: (data) =>{
                            console.log(data);
                            location.reload();
                            alert("Information has been updated!");
                        }    
                      });
                }
                else{
                    alert("Validation Error!");
                }

            });
           
        });

        // delete btn
        $row.append('<input type = "button" name = "btnDelegateItem" value = "Delete">').on('click','input[value = "Delete"]',(e) =>{
            $.ajax({
                url:apiUrl + 'Users/' + $row.children().first().text(),
                type: "DELETE",
                success: (result) =>{
                    console.log(result);
                    alert("User has been deleted!");
                }
            });                      
            
            $row.remove();
        });
    }
}

//validation func
function ValidInfo(){
    if($('#FirstName').val().length < validTextFields || $('#LastName').val().length < validTextFields || $('#Password').val().length < validPassword){
        return false;
    }
    else return true;
}


