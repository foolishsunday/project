	// var table = document.createElement('table');
	// // table.setAttribute('width',300);
	// table.width = 300;
	// table.border = 1;
	// document.body.appendChild(table);

	// var caption=document.createElement('caption');
	// table.appendChild(caption);
	// // caption.innerHTML='成绩表';
	// var catpionText=document.createTextNode('成绩表');
	// caption.appendChild(catpionText);

	// var thead=document.createElement('thead');
	// table.appendChild(thead);

	// var tr=document.createElement('tr');
	// thead.appendChild(tr);

	// var th=document.createElement('th');
	// tr.appendChild(th);

	// var box = document.getElementById("odiv");
	// alert(box.style.length);
	// alert(box.style.cssFloat);
	// alert(box.style.cssText);

	// box.style.setProperty("color","blue");
	// box.style.removeProperty('background');

	// var box = document.getElementById("odiv");

	// // var style=window.getComputedStyle(box,null);
	// var style=box.currentStyle;
	// alert(style.fontSize);

window.onload=function(){
	var box = document.getElementById("box");
	removeClass(box,'aa');
};

//判断一个class是否存在
function hasClass(element,cName){
	return !!element.className.match(new RegExp('(\\s|^)'+cName+'(\\s|$)'));
}

//添加一个class
function addClass(element,cName)
{
	if(!hasClass(element,cName))
		element.className += ' ' + cName;
}

//移除一个class
function removeClass(element,cName){
	if(hasClass(element,cName))
		element.className = element.className.replace(new RegExp('(\\s|^)'+cName+'(\\s|$)'),' ');
}
