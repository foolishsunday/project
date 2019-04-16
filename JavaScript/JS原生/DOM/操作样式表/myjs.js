
	// var link = document.getElementsByTagName('link')[0];
	// var sheet = link.sheet;	//IE不兼容
	// // var sheet = link.sheet || link.styleSheet;
	// alert(sheet);

window.onload=function(){
	// var sheet = document.styleSheets;
	// alert(sheet.length);
	// var link=document.getElementsByTagName('link')[0];
	// var sheet=link.sheet;
	// alert(sheet);
	var sheet = document.styleSheets[0];
	//alert(sheet.cssRules.length);
	var rules=sheet.cssRules;
	alert(rules[3].selectorText); 
	rules[3].style.fontSize="80px"; 
};
