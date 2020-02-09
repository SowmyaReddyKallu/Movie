import React, { Component, useState, useEffect } from 'react'


class MovieUpload extends Component {
    constructor(props) {
        super(props);
        this.state = {
            selectedFile: null
          }
        this.changeText = this.changeText.bind(this);

    }
    changeText(event) {
         
        this.setState({
            selectedFile: event.target.files[0],
            loaded: 0,
          })
    }
    render() { 
        return (<form id="formUpload" onSubmit={event => { event.preventDefault(); this.props.handleUploadClick(this.state.selectedFile); }}>
            <div className="divHeading">Upload</div>
            <table cellPadding='2' cellSpacing='0' className='TableSearch'>
                <tr>
                    <td>Select File</td>
                    <td><input name='file' id='file' type='file' onChange={this.changeText} ></input> </td>
                </tr>
                <tr>
                    <td colSpan="8">
                        <div className="TextAlignRight">
                            <input className="ButtonSearch" type="submit" value="Upload"  ></input>
                            &nbsp;<input className="ButtonSearch" type="button" value="Cancel" onClick={this.props.onCancel}></input>  </div>
                    </td>

                </tr>
            </table>
        </form>
        )

        // return <div>Detail {this.props.TestChild} {this.props.isEditing}</div>
    }
}


export default MovieUpload