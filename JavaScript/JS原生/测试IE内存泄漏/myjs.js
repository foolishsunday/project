function box(){
	var oDiv=document.getElementById('odiv');
	var text=oDiv.innerHTML;
	oDiv.onclick=function(){

		alert(text);
	};

	oDiv=null;
};
box();
/*function box(){
	var oDiv=document.getElementById("odiv");
	var text = oDiv.innerHTML;
	oDiv.onclick=function(){
	alert('text');
	};

}
box();*/



