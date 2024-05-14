import React, { Component } from 'react';
import { variables } from './variables.js';
import './index.css';

const Image = ({ data }) => <img src={`${data}`}/>

export class Games extends Component {
    constructor(props) {
        super(props);
        this.state = {
            games : [],
            game_title : "", 
            genre : "",
            platform : "",
            release_date : "",
            rating : 0.0,
            price : 0.0,
            image_url : "",
            description : "",
            studio_name : ""
        }
    }

    componentDidMount() {

        fetch(variables.API_URL + 'games/all', {
           method: 'get',
           mode: 'cors',
           headers: new Headers({
            'Access-Control-Allow-Origin': '*'
           }) 
        })
            .then(response => response.json())
            .then(data => {
                this.setState({ games: data });
            });
    }

    render() {
        const {
            games
        } = this.state;

        return (
            <div>
                <div className='container'>
                {games.map((game, index) => (
                    <div key={index} className='child'>
                        <Image data={game.image_url} />
                    </div>
                ))}
                </div>
            </div>
        )
    } 


}