//DRY: don't repeat yourself

// vars, functions and if-elese statements
var name = prompt('Please enter yur first name: ')
function go (name, age) {
    alert(name);
    alert(age);
}
go('Dave', 29);

function add(first, second){
     return first+second
}
var sum = add(1,2);
alert('The sum is: '+sum);

function go2 (name, age){
    if (age < 20){
        return name+'!';
    } else {
        return name;
    }
}

alert( go('Dave', 29));

//undefined
var a;
alert(a);
//by default empty variables will be returned as "undefined"