import React from 'react'

import Row from "react-bootstrap/Row";
import Container from "react-bootstrap/Container";

import {Products} from "../Product";

function Dashboard() {
    return (
        <div className="py-3">
          <Container>
              <Row>
                  <Products/>
              </Row>
          </Container>
        </div>
    )
}

export default Dashboard
