function Service(){
	var _count = "0";
	var _map = new Map();

	this.add = function(object){
		_map.set(_count, object);
		_count = String(Number(_count)+1)
	}

	this.getById = function(id){
		if(typeof id == typeof 'string'){
			let objectToRuturn = _map.get(id)
			return objectToRuturn;
			if(typeof objectToRuturn == 'undefined'){
				return null;
			}else{
				return objectToRuturn;
		}
		}else{
			console.log("Error! Incorrect type of id");
		}
	}

	this.getAll = function(){
		let arr = []
		for(const value of _map.values()){
			arr.push(value)
		}
		return arr;
	}
	
	this.deleteById = function(id){
		if(typeof id == typeof 'string'){
			let objectToDelete = _map.get(id);
			if(typeof objectToDelete == 'undefined'){
				return null;
			}
			_map.delete(id);
			return objectToDelete;
		}else{
			console.log("Error! Incorrect type of id");
		}
	}
	
	this.updateById = function(id,object){
		if(typeof id == typeof 'string'){
			if(_map.has(id)){
				_map.set(id,object);
				return true;
			}else{
				return false;
			}
		}else{
			console.log("Error! Incorrect type of id");
		}
	}
}
