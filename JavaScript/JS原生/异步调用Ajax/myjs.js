
function params(data){
	var arr = [];
	for(var i in data){
		arr.push(encodeURIComponent(i+'='+data[i]));
	}
	return arr.join('&');
}

/*readyState:
0 － （未初始化）还没有调用send()方法
1 － （载入）已调用send()方法，正在发送请求
2 － （载入完成）send()方法执行完成，已经接收到全部响应内容
3 － （交互）正在解析响应内容
4 － （完成）响应内容解析完成，可以在客户端调用了
*/


function ajax(obj){
	var xhr = new XMLHttpRequest();
	obj.url = obj.url + '?rand=' + Math.random();
	obj.data = params(obj.data);
	if(obj.method == 'get')
		obj.url += obj.url.indexOf('?') == -1 ? '?' + obj.data : '&'+obj.data;
	xhr.onreadystatechange = function(){
		if(xhr.readyState==4){
			callback();
		}
	}
	xhr.open(obj.method,obj.url,obj.async);
	if(obj.method == 'post'){
		xhr.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
		xhr.send(obj.data);
	}
	else 
		xhr.send(null); 
	if(obj.async === false)
		callback();
	function callback(){
			if(xhr.status == 200){
				obj.success(xhr.responseText);
			}else{
				alert('error');
			}
	}
}

addEvent(document,'click',function(){
	ajax({
		method:'post',
		url:'demo.json',
		data:{
			'name':'Lee',
			'age':100
		},
		success:function(text){
			alert(text);
		},
		async:true

	});
})

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