var React = require("react");

function SuccessCell({value}){
	return (
		<span className="label label-success">{value}</span>
	);
}

module.exports = SuccessCell;