import React, {useEffect, useState} from 'react'

import {getProducts} from "../../utils/api";
import Col from "react-bootstrap/Col";
import CardItem from "../Card/CardItem";

function Products() {
  const [products, setProducts] = useState([])

  useEffect(() => {
    getProducts()
      .then(({data}) => {
        setProducts(data)
      })
  }, [])

  return products.map(product => {
    return (
        <Col md={4} key={product.id}>
          <CardItem {...{product}}/>
        </Col>
    )
  })
}

export default Products
