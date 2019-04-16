
addEvent(window,'load',function(){
	var box = document.getElementById('box');
	box.setAttribute('name',encodeURIComponent('lizong'));
	box.expires = setCookieDate(7);
	box.save('user');

	box.load('user');	
	alert(decodeURIComponent(box.getAttribute('name')));
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