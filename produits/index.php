<?php
require('controller.php');

$method = $_SERVER['REQUEST_METHOD'];

$request = explode('/', trim($_SERVER['REQUEST_URI'], '/'));


function parseInput()
{
    $data = file_get_contents("php://input");
    return json_decode($data, true);
}
// getProduits();
switch ($method) {
    case 'GET':
        if ($request[0] == 'produit') {
            getProduit($request[1]);
        } else {
            getProduits();
        }
        break;
    case 'POST':
        $data = parseInput();
        addProduit($data['libelle'], $data['description'], $data['quantite'], $data['prix']);
        break;
    case 'PUT':
        $data = parseInput();
        updateProduit($data['id'], $data['libelle'], $data['description'], $data['quantite'], $data['prix']);
        break;
    case 'DELETE':
        delete($request[0]);
        break;
    default:
        http_response_code(405);
        break;
}
?>