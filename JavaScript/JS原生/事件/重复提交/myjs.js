

addEvent(window,'load',function(){
	var fm = document.getElementById('formStu');
	var flag = false;

	addEvent(fm,'submit',function(evt){
		preDef(evt);

		document.getElementById('sub').disabled = true;
		if(flag == true)return;
		flag = true;
		setTimeout(function(){
			fm.submit;
		},5000);
	});
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