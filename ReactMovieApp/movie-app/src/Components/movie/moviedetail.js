import React, { Component, useState, useEffect } from 'react'

class MovieDetail extends Component {
    constructor(props) {
        super(props);
        this.state = {
            currentmovie: this.props.currentmovie,
            isEditing: this.props.isEditing
        };
        this.changeText = this.changeText.bind(this);

    }
    changeText(event) {
        let currentmovieTemp = this.props.currentmovie;
        if (event.target.name == "ReleaseYear")
            currentmovieTemp.releaseYear = event.target.value;
        if (event.target.name == "Title")
            currentmovieTemp.title = event.target.value;
        if (event.target.name == "OriginEthnicity")
            currentmovieTemp.originEthinicity = event.target.value;
        if (event.target.name == "Cast")
            currentmovieTemp.cast = event.target.value;
        if (event.target.name == "Genre")
            currentmovieTemp.genre = event.target.value;
        if (event.target.name == "WikiPage")
            currentmovieTemp.wikiPage = event.target.value;
        if (event.target.name == "Plot")
            currentmovieTemp.plot = event.target.value;
        if (event.target.name == "Director")
            currentmovieTemp.director = event.target.value;

        this.setState({ currentmovie: currentmovieTemp });
        //this.props.currentmovie.releaseYear =event.target.value;
        //return val;
    }
    render() {
        const movie = this.props.currentmovie;
        const isEditing = this.props.isEditing;
        if (movie != null && movie != undefined) {
            return (<form onSubmit={event => { event.preventDefault(); this.props.handleSaveClick(movie.id, movie); }}>
                <div className="divHeading">Detail</div>
                <table cellPadding='2' cellSpacing='0' className='TableSearch'>
                    <tr>
                        <td>Release Year</td>
                        <td><input name='ReleaseYear' id='ReleaseYear' type='text' onChange={this.changeText} value={movie.releaseYear} disabled={isEditing}></input> </td>
                        <td>Title</td>
                        <td><input name='Title' id='Title' type='text' onChange={this.changeText} value={movie.title} disabled={isEditing}></input> </td>
                        <td>Origin/Ethnicity</td>
                        <td><input name='OriginEthnicity' id='OriginEthnicity' type='text' onChange={this.changeText} value={movie.originEthinicity} disabled={isEditing}></input> </td>
                        <td>Cast</td>
                        <td><input name='Cast' id='Cast' type='text' onChange={this.changeText} value={movie.cast} disabled={isEditing}></input> </td>
                    </tr>
                    <tr>
                        <td>Genre</td>
                        <td><input name='Genre' id='Genre' type='text' onChange={this.changeText} value={movie.genre} disabled={isEditing}></input> </td>
                        <td>Wiki Page</td>
                        <td><input name='WikiPage' id='WikiPage' type='text' onChange={this.changeText} value={movie.wikiPage} disabled={isEditing}></input> </td>
                        <td>Plot</td>
                        <td><input name='Plot' id='Plot' type='text' onChange={this.changeText} value={movie.plot} disabled={isEditing}></input> </td>
                        <td>Director</td>
                        <td><input name='Director' id='Director' type='text' onChange={this.changeText} value={movie.director} disabled={isEditing}></input></td>
                    </tr>
                    <tr>
                        <td colSpan="8">
                            <div className="TextAlignRight">
                                <input className="ButtonSearch" type="submit" value="Save"  ></input>
                                &nbsp;<input className="ButtonSearch" type="button" value="Cancel" onClick={this.props.onCancel}></input>  </div>
                        </td>

                    </tr>
                </table>
            </form>
            )
        }
        else {
            return <div></div>
        }

        // return <div>Detail {this.props.TestChild} {this.props.isEditing}</div>
    }
}


export default MovieDetail