

document.write(navigator.userAgent+'<br/>');
var client=function(){
	var engine={
		ie:false,
		gecko:false,
		khtml:false,
		webkit:false,
		opera:false,
		ver:0
	};
	var ua=navigator.userAgent;
	if(window.opera){
		engine.opera=true;
		engine.ver=window.opera.version();
	}
	else if(/AppleWebKitV(\S+)/.test(ua))
	{
		engine.webkit=true;
		engine.ver=RegExp['$1'];
	}
	else if(/rv:([^\)]+)\) Gecko\/\d{8}/.test(ua))
	return { 
		engine:engine		//前一个engine是属性，后一个是对象值
	};
}();
document.write(client.engine.webkit); 
