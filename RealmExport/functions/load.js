// This function is the endpoint's request handler.
exports = async function(token) {

    var conn = context.services.get("mongodb-atlas").db("monoposaver").collection("game");
    
    var game = await conn.findOne({token:token});
    if(game != null) {
      delete game._id;
    }
    
    return game;
};
