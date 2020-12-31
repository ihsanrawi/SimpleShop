import React from "react";
import { Link } from "react-router-dom";

import Card from "react-bootstrap/Card";

function CardItem(props) {
  const {id, name, description, price} = props.product
  
      let shorterDescription = description.substring(0, 200);
  
  return (
    <Card className="mb-4 shadow-sm" style={{ width: "15rem" }}>
      <Card.Body>
        <Card.Title>{name}</Card.Title>
        <Card.Subtitle className="mb-2 text-muted">Price - ${price}</Card.Subtitle>
        <Card.Text>
          {shorterDescription}
        </Card.Text>
        <div className="d-flex justify-content-between align-items-center">
          <Link className="btn btn-sm btn-info" to={`/product/${id}`}>More Info</Link>
        </div>
      </Card.Body>
    </Card>
  );
}

export default CardItem;
