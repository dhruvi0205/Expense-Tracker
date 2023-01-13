
            var rIndex,
            table = document.getElementById("table-Category");
function checkEmptyInput()
{
    var isEmpty = false,
        Name = document.getElementById("Name").value,
        Limit = document.getElementById("Limit").value;
       

    if(Name === ""){
        alert("Name Connot Be Empty");
        isEmpty = true;
    }
    else if(Limit === ""){
        alert("Limit Connot Be Empty");
        isEmpty = true;
    }
    return isEmpty;
}