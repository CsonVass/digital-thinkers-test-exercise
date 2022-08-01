import React, { Component } from 'react'
import {Card, Button} from 'react-bootstrap'
import { render } from 'react-dom';

export class DriverCard extends React.Component {
  constructor(props){
    super(props);
  }

  render() {
    return (
        <Card className='card text-center' style={{ width: '18rem'}}>
        <Card.Img variant="top" src="holder.js/100px180" />
        <Card.Body>
          <Card.Title>{this.props.name}</Card.Title>
          <Card.Text>             
            Team: {this.props.team}
          </Card.Text> 
          <Card.Text> 
            Current Place: {this.props.currentPlace}
          </Card.Text> 
          <Card.Text> 
            Code: {this.props.code}
          </Card.Text>
          <Button variant="primary" onClick={this.props.onClick} disabled={this.props.currentPlace==1}>Overtake</Button>
        </Card.Body>
      </Card>
    )
  }
}

export default DriverCard