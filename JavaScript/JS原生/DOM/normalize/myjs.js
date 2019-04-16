window.onload=function(){
	var box=document.getElementById("odiv");

	// var text1=document.createTextNode("LI");
	// var text2=document.createTextNode("28");
	// box.appendChild(text1);
	// box.appendChild(text2);

	//alert(box.childNodes[0].nodeValue);//此处为空白需要用到normalize

	//box.normalize();
	//alert(box.childNodes[0].nodeValue);

	box.firstChild.splitText(6);
	alert(box.childNodes.length); 
	alert(box.childNodes[0].nodeValue);

};
 