// loadScript('load.js');
// function loadScript(url){
// 	var script=document.createElement('script');
// 	script.type = 'text/javascript';
// 	script.src = url;
// 	document.getElementsByTagName('head')[0].appendChild(script);
// }

	// var script = document.createElement('script');
	// script.type='text/javascript';
	// script.text="alert('HELLO')";
	// document.getElementsByTagName('head')[0].appendChild(script);

	//// css-link
	// var link = document.createElement('link');
	// link.rel = 'stylesheet';
	// link.type = 'text/css';
	// link.href = 'basic.css';

	// document.getElementsByTagName('head')[0].appendChild(link);
window.onload=function(){
	var box = document.getElementById('box');

	var style = document.createElement('style');
	style.type = 'text/css';
	style.appendChild(document.createTextNode('#box{background-color:blue;}'));

	document.getElementsByTagName('head')[0].appendChild(style);
};


