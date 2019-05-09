import React, { Component } from 'react';
import { StyleSheet, Text, View, Button } from 'react-native';
import { TextInput } from 'react-native-gesture-handler';
import { Button } from 'native-base';

export default class CadastrarProjeto extends Component {
    constructor() {
        super();
        this.state = {
            nome: "",
            descricao: ""
        }
    }

    componentDidUpdate() {
        // console.warn(this.state.nome)
        // console.warn(this.state.email)

    }

    teste(e) {
        //  this.setState({nome: e.target.value})
        //  this.setState({nome: e})
        console.warn(this.state.nome)
        console.warn(this.state.email)
    }

    render() {
        return (
            <View style={styles.container}>
                <Text>Cadastrar tema</Text>
                <TextInput
                    style={styles.input}
                    onChangeText={(text) => this.setState({ nome: text })}
                    // onChangeText={this.teste.bind(this)}
                    placeholder="Nome do projeto"
                />
                <TextInput
                    style={styles.input}
                    onChangeText={(text) => this.setState({ email: text })}
                    placeholder="Descrição do projeto"
                />
                <Button title="Opa"/>
            </View>
        )
    }
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },

    input: {
        height: 64,
        width: 256,
        borderColor: 'gray',
        borderWidth: 2,
        marginBottom: 25,
        borderRadius: 32,
        paddingLeft: 16
    }
});