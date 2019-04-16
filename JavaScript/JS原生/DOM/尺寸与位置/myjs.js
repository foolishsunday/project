
	// var link = document.getElementsByTagName('link')[0];
	// var sheet = link.sheet;	//IE不兼容
	// // var sheet = link.sheet || link.styleSheet;
	// alert(sheet);

	// var style = window.getComputedStyle(box,null);
	// alert(style.width);
	 
	// var sheet = document.styleSheets[0];
	// var rule = sheet.cssRules[0];
	// alert(rule.style.width);

	// alert(box.clientWidth);
	// alert(box.scrollWidth);
	// alert(box.scrollHeight);

// 	function offsetTop(element){
// 	var top = element.offsetTop;
// 	var parent = element.offsetParent;

// 	while(parent !== null){
// 		top += parent.offsetTop;
// 		parent = parent.offsetParent;
// 	}
// 	return top;
// }
// function offsetLeft(element){
// 	var left = element.offsetLeft;
// 	var parent = element.offsetParent;

// 	while(parent !== null){
// 		left += parent.offsetLeft;
// 		parent = parent.offsetParent;
// 	}
// 	return left;
// }


window.onload=function(){
	var box = document.getElementById('box');
	// alert(box.offsetWidth);
	// alert(box.offsetHeight);
	// alert(box.offsetTop);
	// alert(box.offsetParent.tagName);
	// alert(offsetLeft(box));
	alert(box.getBoundingClientRect().top);
	alert(document.documentElement.clientTop);
};

