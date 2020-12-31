import React, {useEffect, useState} from 'react';
import { useHistory } from "react-router-dom";

import Container from "react-bootstrap/Container";
import Spinner from "react-bootstrap/Spinner";
import Card from "react-bootstrap/Card";
import Col from "react-bootstrap/Col";
import Button from "react-bootstrap/Button";

import {getProduct} from "../../utils/api";
import Row from "react-bootstrap/Row";

function ProductDetails({match}) {
    const [product, setProduct] = useState(null)
    let history = useHistory();
    
    useEffect(() => {
        getProduct(match.params.id)
          .then(({data}) => {
              setProduct(data)
          })
    }, [getProduct, match.params.id])

    return (
        <div className="py-3">
            <Container>
            {
                product === null ? 
                (
                    <Spinner className="center" animation="border"/>
                ): 
                (
                    <Card className="mb-3">
                        <Card.Header>
                            <Row className="px-3 justify-content-between">
                                <Card.Title>{product.name}</Card.Title>
                                <Card.Title className="text-right">${product.price}</Card.Title>
                            </Row>
                        </Card.Header>
                        <Row className="no-gutters">
                            <Col md={4}>
                                <Card.Img src="https://via.placeholder.com/300"/>
                            </Col>
                            <Col md={8}>
                                <Card.Body>
                                    <Card.Title>Description</Card.Title>
                                    <Card.Text>{product.description}</Card.Text>
                                    <div className="d-flex justify-content-between align-items-center">
                                        <Button variant="primary" size="sm" onClick={() => history.goBack()}>Back</Button>
                                    </div>
                                </Card.Body>
                            </Col>
                        </Row>
                    </Card>
                )
            }
            </Container>
        </div>
    )
}

export default ProductDetails
