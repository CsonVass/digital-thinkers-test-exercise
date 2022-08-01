import React from 'react'
import {Card, Button} from 'react-bootstrap'

export class DriverCard extends React.Component {

  render() {
    return (
        <Card className='card text-center' style={{ width: '18rem'}}>
        <Card.Img variant="top" src={`https://localhost:5001/static/${this.props.code}.png`} />
        <Card.Img varint="bottom" src={`https://countryflagsapi.com/png/${this.props.country}`}/>
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
        </Card.Body>   
        <Card.Footer>
        <Button variant="primary" onClick={this.props.onClick} disabled={this.props.currentPlace===1}>Overtake</Button>       

          </Card.Footer>    
      </Card>
    )
  }
}

export default DriverCard