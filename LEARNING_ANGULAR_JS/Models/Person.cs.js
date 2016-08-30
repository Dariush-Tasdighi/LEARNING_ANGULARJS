function inherits(subConstructor, superConstructor) {
    var proto = Object.create(
        superConstructor.prototype,
        {
            "constructor": { 
                configurable: true,
                enumerable: false,
                writable: true,
                value: subConstructor
            }
        }
    );
    Object.defineProperty(subConstructor, "prototype",  { 
        configurable: true,
        enumerable: false,
        writable: true,
        value: proto
    });
}

var server = server || {};
/// <summary>The Person class as defined in Models.Person</summary>
server.Person = function() {
	/// <field name="age" type="Number">**********</field>
	this.age = 0;
	/// <field name="isActive" type="Boolean">********** **********</field>
	this.isActive = false;
	/// <field name="lastName" type="String">********** **********</field>
	this.lastName = '';
	/// <field name="firstName" type="String">********** **********</field>
	this.firstName = '';
};

inherits(Person, BaseEntity);/// <summary>The BaseEntity class as defined in Models.BaseEntity</summary>
server.BaseEntity = function() {
	/// <field name="id" type="Object">The Id property as defined in Models.BaseEntity</field>
	this.id = { };
};

