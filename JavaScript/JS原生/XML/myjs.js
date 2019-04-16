
addEvent(window,'load',function(){
	// var xmlDoc = document.implementation.createDocument('','root',null);
	// xmlDoc.load('data.xml');
	// alert(xmlDoc);

	var xhr = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject("Microsoft.XMLHTTP");
	xhr.open("GET","data.xml",false);
	xhr.send(null);

	var doc = xhr.responseXML;
	alert(doc);
});
function addEvent(obj,type,fn){
	if(obj.addEventListener){
		obj.addEventListener(type,fn,false);
	}else if(obj.attachEvent){
		obj.attachEvent('on'+type,fn);
	}
}

function removeEvent(obj,type,fn){
	if(obj.removeEventListener){
		obj.removeEventListener(type,fn,false);
	}else if(obj.detachEvent){
		obj.detachEvent('on'+type,fn);
	}
}

//跨浏览器阻止默认行为
function preDef(evt){
	var e = evt || window.event;
	if(e.preventDefault){
		e.preventDefault();
	}
	else 
		e.returnValue = false;
}

//过期时间
function setCookieDate(day){
	var date = null;
	if(typeof day=='number' && day>0){
		date = new Date();
		date.setDate(date.getDate()+day);
	}else{
		throw new Error('date error');
	}
	return date;
}

function createXMLDom(){
  if (window.ActiveXObject) 
   var xmldoc=new ActiveXObject("Microsoft.XMLDOM");
  else
   if (document.implementation&&document.implementation.createDocument)
    var xmldoc=document.implementation.createDocument("","doc",null);
  xmldoc.async = false;
  //为了和FireFox一至，这里不能改为False;
  xmldoc.preserveWhiteSpace=true;
  return xmldoc;
}