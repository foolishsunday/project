
addEvent(window,'load',function(){
	var xhr = new XMLHttpRequest();
	xhr.open('get','demo.php',false);
	xhr.send(null);
	// alert(xhr.responseText);
	alert(xhr.status);
	alert(xhr.statusText);
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