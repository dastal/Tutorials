var myList = ['apples', 'oranges', 'bananas']

myList[3] = 'pineapples';
myList[0] = 'watermelon';

function go() {
    alert('hi');
}

//var myList2 = ['apples', 2 , go];

var myList = ['apples', 'oranges', 'bananas'];
//myList.shift() pulls first item out of the list and siplays it
//myList.pop() pulls the last item out and displays it


myList.forEach(function(value, index) {
    console.log(value, index);
});

//loops (while, do, for)
var times = 0;
while (times<10) {
    console.log('tried it', times)
    times++;
}

// difference: do is always going to run once
do {
    console.log('tried it', times)
    times++;
} while(times < 10);

for (var i=0; i<myList.length; i++) {
    console.log(myList[i]);
};

