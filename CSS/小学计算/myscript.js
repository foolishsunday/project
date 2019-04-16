var n1 = Math.floor(20*Math.random());
var n2 = Math.floor(20*Math.random());
document.querySelectorAll(".number1")[0].innerHTML=n1;
document.querySelectorAll(".number2")[0].innerHTML=n2;

var but=document.getElementById("button");
but.onclick=function(){
	var res=document.getElementById("res").value;
	if(res==(n1+n2).toString())
	{

		alert('对了!');
	}
	else
	{
		alert('错了!');
	}
}