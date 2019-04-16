// var num=0, max=5,id=null;
// function box(){
// 	num++;
// 	document.getElementById('odiv').innerHTML=num;
// 	if(num==max)
// 	{
// 		clearInterval(id);
// 		alert('5秒到了!');
// 	}
// }
// id=setInterval(box,1000);

var num=0,max=5;
function box(){
	num++;
	document.getElementById('odiv').innerHTML=num;
	if(num==max)
	{
		alert('5秒到了');
	}
	else
		setTimeout(box,1000);
}
setTimeout(box,1000);