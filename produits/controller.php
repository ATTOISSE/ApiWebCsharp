<?php
require_once "db.php";
header('Content-Type:application/json');

function getProduits()
{
    global $db;
    $sql = "SELECT * FROM produit";
    $stmt = $db->query($sql);
    $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
    echo json_encode($result);
}

function getProduit(int $id)
{
    global $db;
    $sql = "SELECT * FROM produit WHERE id = ?";
    $stmt = $db->prepare($sql);
    $stmt->execute([$id]);
    $result = $stmt->fetch(PDO::FETCH_ASSOC);
    echo json_encode($result);
}
function addProduit(string $libelle, string $description, float $qte, float $prix)
{
    global $db;
    $sql = "INSERT INTO produit (libelle , quantite , description , prix ) VALUES (?, ?, ?, ?)";
    $stmt = $db->prepare($sql);
    $result = $stmt->execute([$libelle, $qte, $description, $prix]);
    echo json_encode("Produit ajouté !");
}

function updateProduit(int $id, string $libelle, string $description, float $qte, float $prix)
{
    global $db;
    $stmt = $db->prepare("UPDATE produit SET libelle = ?, quantite = ?, description = ?, prix = ? WHERE id = ?");
    $result = $stmt->execute([$libelle, $qte, $description, $prix, $id]);
    echo json_encode("Produit modifié!");
}

function delete(int $id)
{
    global $db;
    $stmt = $db->prepare("DELETE FROM produit WHERE id = ?");
    $result = $stmt->execute([$id]);
    echo json_encode("Produit supprimé!");
}
?>