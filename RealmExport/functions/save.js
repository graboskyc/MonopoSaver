// This function is the endpoint's request handler.
exports = function(game) {

    var conn = context.services.get("mongodb-atlas").db("monoposaver").collection("game");
    
    delete game._id;
    
    conn.updateOne({token:game.token}, game, {upsert:true});
};
