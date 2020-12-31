import React from 'react'
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';

import {Dashboard, Header} from "./Components";
import Routes from "./Components/Routes";

function App() {
  
  return (
    <Router>
      <Header/>
      <Switch>
        <Route exact path="/" component={Dashboard}/>
        <Route component={Routes} />
      </Switch>
    </Router>
  )
}

export default App

